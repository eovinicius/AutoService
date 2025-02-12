﻿using MediatR;

using SharedKernel.Erros;

namespace Application.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;
