using MediatR;

namespace UniR.Application.Features.Users.Queries;

public class GetUserQuery(string Email) : IRequest;