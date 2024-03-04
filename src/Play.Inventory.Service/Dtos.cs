using System;

namespace Play.Inventory.Dtos
{
    public record GrantItemsDto(Guid userId, Guid CatalogItemId, int Quantity);
    public record InventoryItemDto(Guid CatalogItemId, string Name, string Description, int Quantity, DateTimeOffset AcquiredDate);

    public record CatalogItemDto(Guid id, string Name, string Description);
}