using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GG.Component
{
    public enum RepositoryItem
    {
        RepositoryItemTextEdit,
        RepositoryItemDateEdit,
        RepositoryItemCheckEdit
    }
    public interface IGGControl
    {
        String GGDataSource { get; set; }

        String GGDataMember { get; set; }

        String GGFieldGroup { get; set; }

        String GGFieldRelation { get; set; }

        void InitializeControl();
    }

   
}
