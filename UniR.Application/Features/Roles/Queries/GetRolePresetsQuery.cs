using MediatR;
using UniR.Contracts.Dto.Roles;
using UniR.Domain.Entities;

namespace UniR.Application.Features.Roles.Queries;

public record GetRolePresets() : IRequest<IEnumerable<RolePresetBriefDto>>;