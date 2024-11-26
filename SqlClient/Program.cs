using SqlClient;

const string connectionString = "Server=ACADEMYFSPD08\\SQLEXPRESS;Database=ToDoList;Integrated Security=True;TrustServerCertificate=True";

using var database = new Database(connectionString);
using var unitOfWork = new UnitOfWork(database);

unitOfWork.Work();