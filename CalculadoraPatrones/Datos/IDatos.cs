using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CalculadoraPatrones.Datos
{
    interface IDatos<T>
    {
        void registrar(T entidad);
        bool loguear(T entidad);
        bool registrar_ingreso(T entidad, int exito);
        bool registrar_operacion(T entidad, string descripcion);
        bool consultar_usuario(T entidad);
    }
}
