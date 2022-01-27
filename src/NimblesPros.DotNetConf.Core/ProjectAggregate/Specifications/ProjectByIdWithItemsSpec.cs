using Ardalis.Specification;
using NimblesPros.DotNetConf.Core.ProjectAggregate;

namespace NimblesPros.DotNetConf.Core.ProjectAggregate.Specifications;

public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
{
  public ProjectByIdWithItemsSpec(int projectId)
  {
    Query
        .Where(project => project.Id == projectId)
        .Include(project => project.Items);
  }
}
