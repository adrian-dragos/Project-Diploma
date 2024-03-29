﻿using Application.DTOs.Car;
using Application.DTOs.Instructor;
using Application.DTOs.Student;
using Application.Features.Queries.Instructor;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class InstructorQueryHandler :
        IRequestHandler<GetInstructorListQuery, IEnumerable<InstructorProfileDto>>,
        IRequestHandler<GetInstructorsShortProfileQuery, IEnumerable<InstructorShortProfileDto>>,
        IRequestHandler< GetInstructorStudentsQuery, IEnumerable<StudentShortProfileDto>>

    {
        private readonly IRepository<Instructor> _instructorRepository;
        private readonly IRepository<Student> _studentRepository;

        public InstructorQueryHandler(IRepository<Instructor> instructorRepository, IRepository<Student> studentRepository)
        {
            _instructorRepository = instructorRepository;
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<InstructorProfileDto>> Handle(GetInstructorListQuery request, CancellationToken cancellationToken)
        {
            var instructors = await _instructorRepository
                .Read()
                .AsNoTracking()
                .Include(i => i.InstructorCars)
                .Where(i => i.GearType == request.Filter.CarGear)
                .Select(i => new InstructorProfileDto
                {
                    Id = i.Id,
                    PhotoId = 0,
                    PhoneNumber = i.Identity.PhoneNumber,
                    FullName = i.Identity.FirstName + " " + i.Identity.LastName,
                    CarModels = i.InstructorCars
                        .Select(ic => new CarModelDto
                        {
                            Manufacturer = ic.Car.CarModel.Manufacturer,
                            Model = ic.Car.CarModel.Model,
                        })
                        .Distinct()
                        .ToList(),
                    Location = i.Location,
                    GearType = i.GearType
                })
                .ToListAsync(cancellationToken);

            if (request.Filter.Cars?.Any() ?? false)
            {
                instructors = instructors
                    .Where(instructor => instructor.CarModels
                        .Any(carModel => request.Filter.Cars
                            .Any(filteredCar => filteredCar.Manufacturer == carModel.Manufacturer &&
                                                 filteredCar.Model == carModel.Model) ))
                    .ToList();
            }

            return instructors;
        }
        public async Task<IEnumerable<StudentShortProfileDto>> Handle(GetInstructorStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.Read()
                .AsNoTracking()
                .Where(i => i.Lessons.Any(l => l.InstructorId == request.InstructorId))
                .Select(s => new StudentShortProfileDto
                {
                    Id = s.Id,
                    FullName = s.Identity.FirstName + " " + s.Identity.LastName
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<InstructorShortProfileDto>> Handle(GetInstructorsShortProfileQuery request, CancellationToken cancellationToken)
        {
            return await _instructorRepository
                .Read()
                .AsNoTracking()
                .Select(i => new InstructorShortProfileDto
                {
                    Id = i.Id,
                    FullName = i.Identity.FirstName + " " + i.Identity.LastName
                })
                .ToListAsync(cancellationToken);
        }
    }
}
