// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Http.Result;

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return one different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
public sealed class Results<TResult1> : IResult
   where TResult1 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1>(TResult1 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return two different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
public sealed class Results<TResult1, TResult2> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2>(TResult2 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return three different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3>(TResult3 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return four different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4>(TResult4 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return five different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5>(TResult5 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return six different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(TResult6 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return seven different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(TResult7 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return eight different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(TResult8 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return nine different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(TResult9 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return ten different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
/// <typeparam name="TResult10">The tenth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
   where TResult10 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult9 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult10"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(TResult10 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return eleven different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
/// <typeparam name="TResult10">The tenth result type.</typeparam>
/// <typeparam name="TResult11">The eleventh result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
   where TResult10 : IResult
   where TResult11 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult9 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult10"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult10 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult11"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(TResult11 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return twelve different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
/// <typeparam name="TResult10">The tenth result type.</typeparam>
/// <typeparam name="TResult11">The eleventh result type.</typeparam>
/// <typeparam name="TResult12">The twelfth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
   where TResult10 : IResult
   where TResult11 : IResult
   where TResult12 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult9 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult10"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult10 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult11"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult11 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult12"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(TResult12 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return thirteen different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
/// <typeparam name="TResult10">The tenth result type.</typeparam>
/// <typeparam name="TResult11">The eleventh result type.</typeparam>
/// <typeparam name="TResult12">The twelfth result type.</typeparam>
/// <typeparam name="TResult13">The thirteenth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
   where TResult10 : IResult
   where TResult11 : IResult
   where TResult12 : IResult
   where TResult13 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult9 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult10"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult10 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult11"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult11 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult12"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult12 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult13"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(TResult13 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return fourteen different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
/// <typeparam name="TResult10">The tenth result type.</typeparam>
/// <typeparam name="TResult11">The eleventh result type.</typeparam>
/// <typeparam name="TResult12">The twelfth result type.</typeparam>
/// <typeparam name="TResult13">The thirteenth result type.</typeparam>
/// <typeparam name="TResult14">The fourteenth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
   where TResult10 : IResult
   where TResult11 : IResult
   where TResult12 : IResult
   where TResult13 : IResult
   where TResult14 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult9 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult10"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult10 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult11"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult11 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult12"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult12 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult13"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult13 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult14"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(TResult14 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return fifteen different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
/// <typeparam name="TResult10">The tenth result type.</typeparam>
/// <typeparam name="TResult11">The eleventh result type.</typeparam>
/// <typeparam name="TResult12">The twelfth result type.</typeparam>
/// <typeparam name="TResult13">The thirteenth result type.</typeparam>
/// <typeparam name="TResult14">The fourteenth result type.</typeparam>
/// <typeparam name="TResult15">The fifteenth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
   where TResult10 : IResult
   where TResult11 : IResult
   where TResult12 : IResult
   where TResult13 : IResult
   where TResult14 : IResult
   where TResult15 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult9 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult10"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult10 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult11"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult11 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult12"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult12 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult13"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult13 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult14"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult14 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult15"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(TResult15 result) => new(result);
}

/// <summary>
/// Represents the result of an <see cref="Endpoint"/> route handler delegate that can return sixteen different <see cref="IResult"/> types.
/// </summary>
/// <typeparam name="TResult1">The first result type.</typeparam>
/// <typeparam name="TResult2">The second result type.</typeparam>
/// <typeparam name="TResult3">The third result type.</typeparam>
/// <typeparam name="TResult4">The fourth result type.</typeparam>
/// <typeparam name="TResult5">The fifth result type.</typeparam>
/// <typeparam name="TResult6">The sixth result type.</typeparam>
/// <typeparam name="TResult7">The seventh result type.</typeparam>
/// <typeparam name="TResult8">The eighth result type.</typeparam>
/// <typeparam name="TResult9">The ninth result type.</typeparam>
/// <typeparam name="TResult10">The tenth result type.</typeparam>
/// <typeparam name="TResult11">The eleventh result type.</typeparam>
/// <typeparam name="TResult12">The twelfth result type.</typeparam>
/// <typeparam name="TResult13">The thirteenth result type.</typeparam>
/// <typeparam name="TResult14">The fourteenth result type.</typeparam>
/// <typeparam name="TResult15">The fifteenth result type.</typeparam>
/// <typeparam name="TResult16">The sixteenth result type.</typeparam>
public sealed class Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16> : IResult
   where TResult1 : IResult
   where TResult2 : IResult
   where TResult3 : IResult
   where TResult4 : IResult
   where TResult5 : IResult
   where TResult6 : IResult
   where TResult7 : IResult
   where TResult8 : IResult
   where TResult9 : IResult
   where TResult10 : IResult
   where TResult11 : IResult
   where TResult12 : IResult
   where TResult13 : IResult
   where TResult14 : IResult
   where TResult15 : IResult
   where TResult16 : IResult
{
    private Results(IResult activeResult)
    {
        Result = activeResult;
    }

    /// <summary>
    /// Gets the actual <see cref="IResult"/> returned by the <see cref="Endpoint"/> route handler delegate.
    /// </summary>
    public IResult Result { get; }

    /// <summary>
    /// Writes an HTTP response reflecting the result.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> for the current request.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous execute operation.</returns>
    public async Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext, nameof(httpContext));

        await Result.ExecuteAsync(httpContext);
    }

    /// <summary>
    /// Converts the <typeparamref name="TResult1"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult1 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult2"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult2 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult3"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult3 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult4"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult4 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult5"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult5 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult6"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult6 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult7"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult7 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult8"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult8 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult9"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult9 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult10"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult10 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult11"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult11 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult12"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult12 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult13"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult13 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult14"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult14 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult15"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult15 result) => new(result);

    /// <summary>
    /// Converts the <typeparamref name="TResult16"/> to a <see cref="Results{TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16}" />.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator Results<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(TResult16 result) => new(result);
}
