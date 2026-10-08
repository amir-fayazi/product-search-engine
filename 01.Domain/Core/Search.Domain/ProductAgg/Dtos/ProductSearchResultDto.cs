

namespace Search.Domain.ProductAgg.Dtos
{
    public record ProductSearchResultDto(
        IReadOnlyList<ProductResultDto> Items,
        int TotalCount,
        int TotalPages,
        int PageNumber,
        int PageSize
    );
}
