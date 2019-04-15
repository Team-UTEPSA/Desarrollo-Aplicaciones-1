using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public interface SQLSerializable
    {
        String toInsert();
        String toUpdate();
        String toDelete();
        String toSelect();
        String toSelect_Parametrizado(String condicion);
        String toSelectTodo();
    }
}
