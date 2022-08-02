using CatStroll.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CatStroll.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);
    }
}