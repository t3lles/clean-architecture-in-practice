using CleanStore.Application.SharedContext.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanStore.Application.SharedContext.UseCases.Abstractions
{
    public interface IQuery <TResponse> : IRequest<Result<TResponse>> where TResponse : ICommandResponse;
    
}
