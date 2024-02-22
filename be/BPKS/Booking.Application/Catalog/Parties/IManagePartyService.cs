﻿using Booking.Application.Catalog.Parties.Dtos;
using BookingSolution.ViewModels.Common;


namespace Booking.Application.Catalog.Parties
{
    public interface IManagePartyService
    {
        Task<int> Create(PartyCreateRequest request);

        Task<int> Update(PartyUpdateRequest request);

        Task<int> Delete(int productId);

        Task<List<PartyVm>> GetAll();

        Task<PagedResult<PartyVm>> GetAllPaging(GetManagePartyPagingRequest request);
    }
}
