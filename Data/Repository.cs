using expenses_report_api;
using Microsoft.EntityFrameworkCore;

public class Repository : IRepository {
   private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Department[]> GetAllDepartmentsAsync()
        {
            IQueryable<Department> query = _context.Departments;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Department> GetDepartmentAsyncById(int departmentId)
        {
            IQueryable<Department> query = _context.Departments;

            query = query.AsNoTracking()
                         .OrderBy(department => department.Id)
                         .Where(department => department.Id == departmentId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Department[]> GetDepartmentsAsyncByName(string name)
        {
            IQueryable<Department> query = _context.Departments;

        
            query = query.AsNoTracking()
                         .OrderBy(department => department.Id)
                         .Where(department => department.Name == name);

            return await query.ToArrayAsync();
        }
}
    