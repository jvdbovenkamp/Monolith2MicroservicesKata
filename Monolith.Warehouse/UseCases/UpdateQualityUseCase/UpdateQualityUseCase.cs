﻿using Warehouse.Core;
using Warehouse.Infra;

namespace Warehouse.UseCases.UpdateQualityUseCase;

public class UpdateQualityUseCase
{
    private readonly IWarehouseRepository _warehouseRepository;

    public UpdateQualityUseCase(IWarehouseRepository warehouseRepository)
    {
        _warehouseRepository = warehouseRepository;
    }

    // used for simulation
    public async Task UpdateQuality()
    {
        var stock = await _warehouseRepository.GetAllAsync();

        var gildedRose = new GildedRose(stock.ToList());

        gildedRose.UpdateQuality();

        await _warehouseRepository.SaveChangesAsync();
    }
}