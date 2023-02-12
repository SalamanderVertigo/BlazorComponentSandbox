using ComponentSandbox.Models;

namespace ComponentSandbox.Services;

public class GridDataService
{
    public List<GridRowData> LoadGridRowData()
    {
        return new List<GridRowData>()
        {
            new GridRowData() {Id = "0", Name = "Electronics", Value = 1},
            new GridRowData() {Id = "1", Name = "Electronics", Value = 2},
            new GridRowData() {Id = "3", Name = "Electronics", Value = 3},
            new GridRowData() {Id = "4", Name = "Electronics", Value = 4},
        };
    }
}