using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gymone.Entities;

namespace Gymone.API.Repository
{
    public interface IRegisterMember
    {
        int InsertMember(MemberRegistrationDTO objMRDTO);
        IEnumerable<MemberRegistrationDTO> GetMember();
        MemberRegistrationDTO GetMemberbyID(string MemID);
        int UpdateMember(MemberRegistrationDTO MemID); //U
        void DeleteMember(string MemID); //D
        string GetAmount(string MemID, string WorkTypeID);
    }
}