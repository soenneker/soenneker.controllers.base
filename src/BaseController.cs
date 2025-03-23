using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace Soenneker.Controllers.Base;

/// <summary>
/// A derivative of ControllerBase, an abstract .NET API controller
/// </summary>
public abstract class BaseController : ControllerBase
{
    protected IConfiguration Config { get; private set; }

    protected BaseController(IConfiguration config)
    {
        Config = config;
    }
}