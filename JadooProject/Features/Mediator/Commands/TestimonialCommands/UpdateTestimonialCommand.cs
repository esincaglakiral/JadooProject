﻿using MediatR;

namespace JadooProject.Features.Mediator.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand : IRequest
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
    }
}
