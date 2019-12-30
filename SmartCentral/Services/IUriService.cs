using System;
using SmartCentral.Contracts.V1.Requests.Queries;

namespace SmartCentral.Services
{
    public interface IUriService
    {
        Uri GetPostUri(string postId);

        Uri GetAllPostsUri(PaginationQuery pagination = null);
    }
}