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




  // PARA LA SECCION CONTACTOS

// JavaScript for opening email when button is clicked

document.querySelectorAll('.email-button').forEach(button => {
    button.addEventListener('click', function() {
      const emailText = this.getAttribute('data-email');
      window.location.href = 'mailto:' + emailText;
    });
  });
  
  

// JavaScript for contact item hover animation

document.querySelectorAll('.contact-item').forEach(contactItem => {
    contactItem.addEventListener('mouseover', function() {
      this.style.transform = 'scale(1.1)';
    });
  
    contactItem.addEventListener('mouseout', function() {
      this.style.transform = 'scale(1)';
    });
  });


  
  
  
  