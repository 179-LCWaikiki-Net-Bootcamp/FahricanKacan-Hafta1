﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Application.Dtos;
using Week2.Domain.Entities;

namespace Week2.Application.Features.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommandRequest:IRequest<CreateProductCommandResponse>
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }  
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public InventoryDto Inventory{ get; set; }
        //public Guid InventoryId { get; set; }
        public Guid DiscountId { get; set; }
        
    }
}
