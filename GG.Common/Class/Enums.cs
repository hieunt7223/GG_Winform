using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GG.Common.Class
{
    public enum Status
    {
        Alive,
        Delete,
        Dummy
    }

    public enum ADConfigValueColumn
    {
        ADConfigKeyValue,
        ADConfigText,
        ADConfigKeyGroup
    }

    public enum ButtonAction
    { 
        btnNew,
        btnNewByUI,
        btnSave,
        btnCancel,
        btnDelete,
        btnEdit,
    }
}
