using expenses_report_api;

public interface IRepository {
   void Add<T>(T entity) where T : class;
  void Update<T>(T entity) where T : class;
  void Delete<T>(T entity) where T : class;
  Task<bool> SaveChangesAsync();

  //Department
  Task<Department[]> GetAllDepartmentsAsync();        
  Task<Department[]> GetDepartmentsAsyncByName(string departmentName);
  Task<Department> GetDepartmentAsyncById(int departmentId);
}