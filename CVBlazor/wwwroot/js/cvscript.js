function onScroll(interval) {

    const 
        language_section = document.querySelector('.lang'),
        skills_section = document.querySelector('.skill');

    window.addEventListener('scroll', function (e) {
        const scrollValue = window.scrollY - 200;
        if (scrollValue > (language_section.scrollHeight + language_section.clientHeight)) {
            console.log("lang");
            const languages = document.querySelectorAll('.lang .percentage');
            languages.forEach(language => {
                language.classList.add("move");
            });
        } else if (scrollValue < (language_section.scrollHeight + language_section.clientHeight)) {
            const languages = document.querySelectorAll('.lang .percentage');
            languages.forEach(language => {
                language.classList.remove("move");
            });
        }
        if (scrollValue > (skills_section.scrollHeight + skills_section.clientHeight)) {
            const skills = document.querySelectorAll('.skill .percentage');
            skills.forEach(skill => {
                skill.classList.add("move");
            });
        } else if (scrollValue < (skills_section.scrollHeight + skills_section.clientHeight)) {
            const skills = document.querySelectorAll('.skill .percentage');
            skills.forEach(skill => {
                skill.classList.remove("move");
            });
        }
    }, interval);
}