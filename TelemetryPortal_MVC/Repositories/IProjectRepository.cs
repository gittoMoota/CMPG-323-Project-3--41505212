using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectByIdAsync(Guid id);
        Task CreateProjectAsync(Project project);
        Task UpdateProjectAsync(Project project);
        Task DeleteProjectAsync(Guid id);
        bool ProjectExists(Guid id);
    }
}
