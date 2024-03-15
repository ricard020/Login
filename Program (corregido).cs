using System;
using System.Data.SqlClient; // Libreria para el manejo de la base de datos

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Inicializa los componentes graficos
            InitializeComponent();
        }

        // Conección de C# con la base de datos de SQL Server  | Nombre del servidor| nombre de la BD | Seguridad |
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\v11.0;Initial Catalog=Login_csharp;Integrated Security=True");

        // Metodo para validar los datos del Login
        public void Logear(string user, string password)
        {
            // Manejo de errores
            try
            {
                //Abrimos la conexion
                con.Open(); 
                // Consulta SQL para la peticion de los datos
                SqlCommand cmd = new SqlCommand("SELECT Name, User_type FROM Ususarios WHERE User = @user AND Password = @pass", con);
                // Agregando los parametros al comando SQL
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("pass", password);
                
                using(SqlDataReader reader = cmd.ExecuteReader());

                if (cmd.ExecuteNonQuery() == 1){
                    if(reader.Read()); // Verifica los datos del usuario
                    {   
                        string user = reader["user"].ToString();
                        string password = reader["pass"].ToString();
                        if (pass == password) { return true; } //Si las contraseñas son iguales ingresa
                                else { return false; }
                            }
                            
                        }
                        else { return false; } //Si el Data Reader no abre se devuelve false
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                // Cierra la conección a la Base de Datos
                con.Close();
            }            
               
                            

                                
                    
                   

               
                
              
        }     
    }
}
