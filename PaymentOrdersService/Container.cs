using PaymentOrdersData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace PaymentOrders.App_Start
{
    public static class Container
    {
        #region Properties

        /// <summary>
        /// Get the current configured container
        /// </summary>
        /// <returns>Configured container</returns>
        public static IUnityContainer Current { get; private set; }

        #endregion

        #region Constructor

        static Container()
        {
            ConfigureContainer();
        }

        #endregion

        #region Methods

        private static void ConfigureContainer()
        {
            /*
            * Add here the code configuration or the call to configure the container
            * using the application configuration file
            */

            Current = new UnityContainer();

            //-> Repositories
            Current.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            //DbContext
            Current.RegisterType<IDbContext, PaymentOrderContext>();
        }

        #endregion
    }
}