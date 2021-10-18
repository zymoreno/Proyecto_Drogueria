using Microsoft.EntityFrameworkCore;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Persistencia
{
    public class AppContext : DbContext
    {
         public DbSet<Bodega> Bodega { get; set; }
         public DbSet<Cliente> Cliente { get; set; }
         public DbSet<Empleado> Empleado { get; set; }
         public DbSet<Estado> Estado { get; set; }
         public DbSet<Factura> Factura{ get; set; }
         public DbSet<OrdenCompra> OrdenCompra { get; set; }
         public DbSet<OrdenProducto> OrdenProducto { get; set; }
         public DbSet<Producto> Producto { get; set; }
         public DbSet<ProductoFactura> ProductoFactura { get; set; }
         public DbSet<Proveedor> Proveedor { get; set; }
         public DbSet<TipoFactura> TipoFactura { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            if (!optionsBuilder.IsConfigured)
            {


                optionsBuilder
               //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =ProyectoG58");
<<<<<<< HEAD
                .UseSqlServer("Server=localhost; Database=ProyectoG58; user id=sa; password=Juan2012");
=======
<<<<<<< HEAD
                .UseSqlServer("Server=localhost; Database=ProyectoG58; user id=sa; password=1234");
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
                //.UseMySQL("server=localhost;port=3306; database=proyectog58;user=lmosquer;password=12345;old guids=true; default command timeout=800;");
=======
                .UseSqlServer("Server=localhost; Database=ProyectoG58; user id=sa; password=Juan2012");
                //UseMySQL("server=localhost;port=3306; database=proyectog58;user=lmosquer;password=12345;old guids=true; default command timeout=800;");
>>>>>>> a76a560baca89fdb12ad375d19d94fab53c92fb3
            }
        }    
    }
}
