using WebApplication3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // �������� ������ ����������� �� ����� ������������
        string connection = builder.Configuration.GetConnectionString("DefaultConnection");

        // ��������� �������� ApplicationContext � �������� ������� � ����������
        builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
        builder.Services.AddRazorPages();

        var app = builder.Build();

        app.MapRazorPages();

        app.Run();

        //Soil_Moisture_Sensor a = new Soil_Moisture_Sensor(1);
        //a.GetData();
    }
}