﻿using ProjectTracker.Contracts;
using ProjectTracker.Entities.DBContext;
using ProjectTracker.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Repositories
{
    public class BoardRepository : RepositoryBase<Boards>, IBoardRepository
    {
        public BoardRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
