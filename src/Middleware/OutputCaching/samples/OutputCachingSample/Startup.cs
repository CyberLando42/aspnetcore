// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.OutputCaching.Policies;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOutputCaching(options =>
{
    // options.Policies.Clear();
    options.Policies.Add(new EnableCachingPolicy());

    options.Profiles["NoCache"] = new OutputCachePolicyBuilder().NoStore().Build();
});

var app = builder.Build();

app.UseOutputCaching();

app.MapGet("/", Gravatar.WriteGravatar).OutputCache(x => x.Tag("home"));

app.MapGet("/a", Gravatar.WriteGravatar).OutputCache();

app.MapGet("/b", Gravatar.WriteGravatar);

app.MapGet("/nocache", Gravatar.WriteGravatar).OutputCache(x => x.NoStore());

app.MapGet("/profile", Gravatar.WriteGravatar).OutputCache(x => x.Profile("NoCache"));

app.MapGet("/attribute", [OutputCache(Profile = "NoCache")] (c) => Gravatar.WriteGravatar(c));

app.MapPost("/purge/{tag}", async (IOutputCacheStore cache, string tag) =>
{
    // POST such that the endpoint is not cached itself

    await cache.EvictByTagAsync(tag);
});

// Cached entries will vary by culture, but any other additional query is ignored and returns the same cached content
app.MapGet("/query", Gravatar.WriteGravatar).OutputCache(p => p.VaryByQuery("culture"));

app.MapGet("/vary", Gravatar.WriteGravatar).OutputCache(c => c.VaryByValue(() => ("time", (DateTime.Now.Second % 2).ToString())));

long requests = 0;

// Locking is enabled by default
app.MapGet("/lock", async (context) =>
{
    await Task.Delay(1000);
    await context.Response.WriteAsync($"<pre>{requests++}</pre>");
}).OutputCache(p => p.Lock(false).Expires(TimeSpan.FromMilliseconds(1)));

// Cached because Response Caching policy and contains "Cache-Control: public"
app.MapGet("/headers", async context =>
{
    // From a browser this endpoint won't be cached because of max-age: 0
    context.Response.Headers.CacheControl = CacheControlHeaderValue.PublicString;
    await context.Response.WriteAsync("Headers " + DateTime.UtcNow.ToString("o"));
}).OutputCache(new ResponseCachingPolicy());

// Etag
app.MapGet("/etag", async (context) =>
{
    // If the client sends an If-None-Match header with the etag value, the server
    // returns 304 if the cache entry is fresh instead of the full response

    var etag = $"\"{Guid.NewGuid().ToString("n")}\"";
    context.Response.Headers.ETag = etag;

    await context.Response.WriteAsync("Hello");
}).OutputCache();

// When the request header If-Modified-Since is provided, return 304 if the cached entry is older
app.MapGet("/ims", Gravatar.WriteGravatar).OutputCache();

await app.RunAsync();
