using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace Soenneker.Controllers.Base;

/// <summary>
/// Provides an ASP.NET Core <see cref="ControllerBase"/> with protected access to application configuration.
/// </summary>
public abstract class BaseController : ControllerBase
{
    /// <summary>
    /// Gets the application configuration supplied to the controller.
    /// </summary>
    protected IConfiguration Config { get; }

    protected BaseController(IConfiguration config)
    {
        Config = config;
    }
}
