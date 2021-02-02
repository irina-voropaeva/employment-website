using System.Collections.Generic;
using System.Threading.Tasks;

namespace KsuEmployment.Services.Employment.Vacancy
{
    public class VacancyService : IVacancyService
    {
        private readonly string loremIpsum =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nulla diam, mattis a erat eu, vehicula dictum massa. Pellentesque ac rhoncus turpis, ut vehicula risus. Mauris condimentum vehicula lacus. Integer massa mi, suscipit ut vehicula sed, finibus eu velit. Donec sed ipsum convallis, molestie turpis quis, ullamcorper risus. Integer ac fermentum odio, sit amet suscipit nisl. Donec ullamcorper, ex at placerat vehicula, augue massa lacinia felis, eget mattis risus massa vitae justo. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer dui metus, facilisis et nibh fermentum, blandit luctus nunc. Morbi euismod tellus urna, sed condimentum magna tincidunt sed. Phasellus blandit urna ac massa mattis, at accumsan purus fringilla. Etiam quis purus tincidunt, ultrices libero quis, vestibulum mauris. Sed non lectus ligula." +
            "Cras rhoncus leo ex.Phasellus sagittis euismod dui non ultrices.Maecenas posuere faucibus nunc, a sagittis nibh.Suspendisse potenti. In consectetur ac ante ac tincidunt. Integer urna magna, pellentesque et lorem vitae, suscipit sodales turpis.Aliquam sit amet nisi sollicitudin, tincidunt nisl ac, faucibus nisl. Curabitur mattis urna dolor. Quisque commodo neque ut auctor faucibus. Duis consequat turpis hendrerit euismod tempus. Cras orci enim, mollis sed pharetra eu, tincidunt non odio.Suspendisse potenti. Nulla vel lacus condimentum, fringilla tortor in, efficitur orci." +
            "Integer lacinia pulvinar tortor a porttitor. Donec vel magna nec metus rutrum tempus.Ut in elit metus. Duis condimentum tempor rutrum. Proin in sem in nunc suscipit volutpat ac et purus. Nam pellentesque lorem ligula. Ut eu dapibus magna." +
            "Sed dictum scelerisque nibh vitae facilisis. Vestibulum dui mi, gravida vitae consectetur fermentum, rutrum lobortis orci.Phasellus suscipit malesuada dictum. Etiam sed justo pellentesque nunc elementum maximus in non dui. Etiam eu neque sapien. Nulla facilisi. Ut enim dui, rhoncus in ultricies at, efficitur nec turpis.Aliquam interdum lacinia nibh, vel laoreet nisl aliquam non.Praesent mollis ipsum ligula, laoreet sollicitudin lacus viverra a.Suspendisse ut orci sed odio semper sagittis.Fusce lorem est, placerat ac quam a, blandit faucibus velit.Sed et ultrices libero. Donec laoreet sed ligula vel tincidunt. Sed iaculis ligula arcu, nec tincidunt ante accumsan ut.Duis nec tellus felis. Nunc placerat rhoncus cursus." +
            "Nullam at iaculis erat. Donec sed ultrices mauris, nec euismod tortor.Morbi sollicitudin nibh sed iaculis bibendum. Morbi cursus nulla in tristique congue. Praesent euismod scelerisque odio consectetur porta. Integer eu volutpat mi. Suspendisse sed neque vehicula, laoreet sapien a, convallis arcu. Nullam diam purus, tristique at neque at, dignissim feugiat leo.Sed sodales vulputate dui ut gravida.";

        public async Task<List<VacancyDto>> GetAll()
        {
            return new()
            {
                new()
                {
                    ContactPersonName = "Evgen Ivanov", ContactPersonRefId = null,
                    Description = loremIpsum, PositionName = "Middle fullstack developer", SalaryMax = 1000500,
                    SalaryMin = 330000
                },
                new()
                {
                    ConcreteSalary = 3000,
                    ContactPersonName = "Avgust Valentinov",
                    ContactPersonRefId = null,
                    Description = loremIpsum,
                    PositionName = "Courier",
                },
                new()
                {
                    ConcreteSalary = 23000,
                    ContactPersonName = "Main Policeman",
                    ContactPersonRefId = null,
                    Description = loremIpsum,
                    PositionName = "Policeman",
                },
            };
        }
    }
}
