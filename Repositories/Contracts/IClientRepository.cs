﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(int id);
        Client Add(Client client);
        Client Update(Client client);
       
        bool Delete(int id);
        //FamilleTier GetFamilleTier(int id);
        //Client GetByDocLig(int id);
    }
}
