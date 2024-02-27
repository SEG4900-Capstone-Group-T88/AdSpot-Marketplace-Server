﻿namespace AdSpot.Api.Mutations;

[MutationType]
public class ListingMutations
{
    [UseProjection]
    public IQueryable<Listing> AddListing(int listingTypeId, int userId, decimal price, ListingRepository repo)
    {
        var listing = repo.AddListing(new Listing
        {
            ListingTypeId = listingTypeId,
            UserId = userId,
            Price = price
        });

        return listing;
    }
}