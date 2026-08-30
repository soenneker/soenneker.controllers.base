[![](https://img.shields.io/nuget/v/soenneker.controllers.base.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.controllers.base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.controllers.base/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.controllers.base/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.controllers.base.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.controllers.base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.controllers.base/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.controllers.base/actions/workflows/codeql.yml)

# Soenneker.Controllers.Base

Provides an abstract ASP.NET Core `ControllerBase` that exposes injected `IConfiguration` to derived controllers through a protected `Config` property.

## Install

```bash
dotnet add package Soenneker.Controllers.Base
```

## Usage

```csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Soenneker.Controllers.Base;

[ApiController]
[Route("api/status")]
public sealed class StatusController : BaseController
{
    public StatusController(IConfiguration configuration) : base(configuration)
    {
    }

    [HttpGet]
    public IActionResult Get()
    {
        string? environment = Config["Environment"];
        return Ok(new { environment });
    }
}
```

`BaseController` adds no routes, filters, authorization policy, API-versioning behavior, or service registration. Derived controllers remain responsible for their normal ASP.NET Core attributes and must pass `IConfiguration` to the base constructor.

`Config` references the application's composed configuration. Whether values update at runtime depends on the underlying providers. Avoid returning secrets or raw configuration values from controller actions.
