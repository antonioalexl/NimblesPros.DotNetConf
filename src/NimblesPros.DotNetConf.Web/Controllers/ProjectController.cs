﻿using NimblesPros.DotNetConf.Core.ProjectAggregate;
using NimblesPros.DotNetConf.Core.ProjectAggregate.Specifications;
using NimblesPros.DotNetConf.SharedKernel.Interfaces;
using NimblesPros.DotNetConf.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace NimblesPros.DotNetConf.Web.Controllers;

[Route("[controller]")]
public class ProjectController : Controller
{
  private readonly IRepository<Project> _projectRepository;

  public ProjectController(IRepository<Project> projectRepository)
  {
    _projectRepository = projectRepository;
  }

  // GET project/{projectId?}
  [HttpGet("{projectId:int}")]
  public async Task<IActionResult> Index(int projectId = 1)
  {
    var spec = new ProjectByIdWithItemsSpec(projectId);
    var project = await _projectRepository.GetBySpecAsync(spec);
    if (project == null)
    {
      return NotFound();
    }

    var dto = new ProjectViewModel
    {
      Id = project.Id,
      Name = project.Name,
      Items = project.Items
                    .Select(item => ToDoItemViewModel.FromToDoItem(item))
                    .ToList()
    };
    return View(dto);
  }
}
