using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Gymone.API.Repository
{
    public interface IReceipt 
    {
        DataSet GenerateRecepitDataset(string MemberID);
        DataSet GenerateDeclarationDataset(string MemberID);
    }
}
