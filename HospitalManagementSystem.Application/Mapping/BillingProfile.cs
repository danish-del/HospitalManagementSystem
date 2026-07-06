using AutoMapper;
using HospitalManagementSystem.Application.Dto.Billing;
using HospitalManagementSystem.Application.Dto.BillingDto;
using HospitalManagementSystem.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Mapping
{
    public class BillingProfile :Profile
    {
        public BillingProfile()
        {
            CreateMap<Billing, CreateBillingDto>();
            CreateMap<BillingDto, Billing>();
            CreateMap<UpdateBillingDto,Billing>();
        }
    }
}
