﻿using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface ICampDao
    {
        List<Camper> FetchAllCampers();
    }
}