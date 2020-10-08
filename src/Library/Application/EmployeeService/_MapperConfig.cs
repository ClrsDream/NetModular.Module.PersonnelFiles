using AutoMapper;
using NetModular.Lib.Mapper.AutoMapper;
using NetModular.Module.PersonnelFiles.Application.EmployeeService.ViewModels;
using NetModular.Module.PersonnelFiles.Domain.Employee;
using NetModular.Module.PersonnelFiles.Domain.EmployeeContact;
using NetModular.Module.PersonnelFiles.Domain.EmployeeEducation;
using NetModular.Module.PersonnelFiles.Domain.EmployeeFamily;
using NetModular.Module.PersonnelFiles.Domain.EmployeeLeaveInfo;
using NetModular.Module.PersonnelFiles.Domain.EmployeePersonal;
using NetModular.Module.PersonnelFiles.Domain.EmployeeWork;

namespace NetModular.Module.PersonnelFiles.Application.EmployeeService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<EmployeeAddModel, EmployeeEntity>();
            cfg.CreateMap<EmployeeEntity, EmployeeBaseUpdateModel>();
            cfg.CreateMap<EmployeeBaseUpdateModel, EmployeeEntity>();

            //��ְ��Ϣ
            cfg.CreateMap<EmployeeLeaveModel, EmployeeLeaveInfoEntity>();

            //������Ϣ
            cfg.CreateMap<EmployeePersonalUpdateModel, EmployeePersonalEntity>();
            cfg.CreateMap<EmployeePersonalEntity, EmployeePersonalUpdateModel>();

            //ͨѶ��Ϣ
            cfg.CreateMap<EmployeeContactUpdateModel, EmployeeContactEntity>();
            cfg.CreateMap<EmployeeContactEntity, EmployeeContactUpdateModel>();

            //��ͥ���
            cfg.CreateMap<EmployeeFamilyAddModel, EmployeeFamilyEntity>();
            cfg.CreateMap<EmployeeFamilyUpdateModel, EmployeeFamilyEntity>();
            cfg.CreateMap<EmployeeFamilyEntity, EmployeeFamilyUpdateModel>();

            //��������
            cfg.CreateMap<EmployeeEducationAddModel, EmployeeEducationEntity>();
            cfg.CreateMap<EmployeeEducationUpdateModel, EmployeeEducationEntity>();
            cfg.CreateMap<EmployeeEducationEntity, EmployeeEducationUpdateModel>();

            //��������
            cfg.CreateMap<EmployeeWorkAddModel, EmployeeWorkEntity>();
            cfg.CreateMap<EmployeeWorkUpdateModel, EmployeeWorkEntity>();
            cfg.CreateMap<EmployeeWorkEntity, EmployeeWorkUpdateModel>();

        }
    }
}
