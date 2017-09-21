# Kural.ToggleJobs
ToggleJobs
Welcome to the Kural.ToggleJobs wiki! This project We have aimed at building a job portal that lists all c# jobs from different sources (Indeed,LinkedIn etc). The site will be created as a Azure WebApp. Our Idea is to

Create Azure WebApp, that will be front end website providing job search functionality
Create Azure WebJobs that will consume APIs from different job source providers (e.g Indeed.com and LinkedIn) and populate into Azure Service Bus
Another WebJob would then index these queued items into Azure search.
We intend to follow the architecture guideline provided from Microsoft here, with the exception of Azure AD, as we do not foresee the login feature at the moment
