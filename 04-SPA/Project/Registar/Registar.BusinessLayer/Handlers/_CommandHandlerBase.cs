﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using System.Data.Entity;
using Registar.DataLayer;
using Registar.Common.Interfaces;

namespace Registar.BusinessLayer.Handlers
{
    /// <summary>
    /// Abstract class for all command handlers
    /// </summary>
    public abstract class CommandHandlerBase<TRequest,TResult> : IHandler where TRequest:Command
                                                                          where TResult:CommandResult
    {
        public IContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public CommandResult Execute(Command command)
        {
            return ExecuteCommand((TRequest)command);
        }

        /// <summary>
        /// The method that executes the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected abstract TResult ExecuteCommand(TRequest command);

    }

    /// <summary>
    /// Abstraction for the operations with the data.
    /// </summary>
    public interface IHandler
    {
        IContext Context { get; set; }

        CommandResult Execute(Command command);
    }
}
