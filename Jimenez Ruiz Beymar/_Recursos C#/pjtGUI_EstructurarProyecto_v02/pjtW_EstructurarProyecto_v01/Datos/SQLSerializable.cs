using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtW_EstructurarProyecto_v01.Datos
{
    public interface SQLSerializable
    {
        String toInsert();
        String toUpdate();
        String toDelete();
        String toSelect();
        String toSelectTodo();
        String toSelect_Parametrizado(String condicion);

    }
}
