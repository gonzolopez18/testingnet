using System;
using System.Collections.Generic;
using Common.Model;

namespace Common.Interfaces.Business
{
    public interface IRandomManager
    {
        public IList<RandomGame> GetRandomGames();
    }
}

