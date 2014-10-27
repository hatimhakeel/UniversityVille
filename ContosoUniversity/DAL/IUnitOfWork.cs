using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public interface IUnitOfWork
    {
        GenericRepository<Department> DepartmentRepository { get; }
        GenericRepository<Course> CourseRepository { get; }
    }
}
