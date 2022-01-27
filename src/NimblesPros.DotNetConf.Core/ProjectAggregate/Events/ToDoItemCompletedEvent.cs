using NimblesPros.DotNetConf.Core.ProjectAggregate;
using NimblesPros.DotNetConf.SharedKernel;

namespace NimblesPros.DotNetConf.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
