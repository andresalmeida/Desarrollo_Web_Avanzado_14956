document.querySelectorAll('nav li').forEach(navItem => {
    navItem.addEventListener('click', function() {
      const sectionId = this.getAttribute('data-section');
      const sections = document.querySelectorAll('.section');
  
      sections.forEach(section => {
        if (section.id === sectionId) {
          section.style.display = 'block';
        } else {
          section.style.display = 'none';
        }
      });
    });
  });
  