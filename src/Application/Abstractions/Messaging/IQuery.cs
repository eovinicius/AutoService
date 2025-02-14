﻿using Domain.Abstractions.Erros;

using MediatR;


namespace Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;