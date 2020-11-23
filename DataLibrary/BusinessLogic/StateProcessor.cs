using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class StateProcessor
    {
        public static int CreateState(int stateId, string stateName, string stateCode)
        {
            StatesModel data = new StatesModel
            {
                StateId = stateId,
                StateName = stateName,
                StateCode = stateCode
            };

            string sql = @"INSERT INTO dbo.States (StateId, StateName, StateCode)
                            values (@StateId, @StateName, @StateCode);";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<StatesModel> LoadStates()
        {
            string sql = @"SELECT StateId, StateName, StateCode from dbo.States;";

            return SQLDataAccess.LoadData<StatesModel>(sql);
        }
    }
}
