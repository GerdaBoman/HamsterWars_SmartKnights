using AutoMapper;
using FakeItEasy;
using HamsterWars.Server.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars.Test.HamsterController
{
    public class HamsterControllerTest
    {
        private readonly IHamsterRepository _repository;
        private readonly IMapper _mapper;
        public HamsterControllerTest()
        {
            _repository = A.Fake<IHamsterRepository>();
            _mapper = A.Fake<IMapper>();
        }

        [Fact]
        public void HamsterController_GetHamsters_ReturnOK()
        {
            //Arrange
            
            //Act
            //Assert
        }

    }
}
