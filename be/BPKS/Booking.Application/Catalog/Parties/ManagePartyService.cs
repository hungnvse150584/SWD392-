﻿using Booking.Application.Catalog.Parties.Dtos;
using BookingSolution.Utilities.Exceptions;
using BookingSolution.ViewModels.Common;
using BPKS.EF;
using BPKS.Entities;

namespace Booking.Application.Catalog.Parties
{
    public class ManagePartyService : IManagePartyService
    {
        private readonly BookingDBContext _context;
        public ManagePartyService(BookingDBContext context)
        {
            _context = context;
        }

        public async Task<int> Create(PartyCreateRequest request)
        {
            var party = new Party()
            {
                PartyName = request.PartyName,
                Description = request.Description,
                PhoneContact = request.PhoneContact,
                Place = request.Place,
                //ThumbnailUrl = request.ThumbnailUrl,
                DayStart = request.DayStart,
                DayEnd = request.DayEnd,
                CreatedDate = DateTime.Now,
                PartyStatus = request.PartyStatus,
                //PartyTranslations = new List<PartyTranslation>()
                //{
                //    new PartyTranslation()
                //    {

                //    }
                //}

            };
            _context.Parties.Add(party);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int partyId)
        {
            var party = await _context.Parties.FindAsync(partyId);
            if (party != null) throw new BookingException($"Cannot find a party: {partyId}");
            _context.Parties.Remove(party);
            return await _context.SaveChangesAsync();
        }

        public Task<List<PartyViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<PartyViewModel>> GetAllPaging(GetManagePartyPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(PartyUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}