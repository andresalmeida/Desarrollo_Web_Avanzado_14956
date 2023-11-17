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


  // PARA LA SECCION SOBRE MI

  document.querySelectorAll('.info-list li').forEach(item => {
    item.addEventListener('mouseover', function () {
      this.style.backgroundColor = '#f0f0f0';
    });
  
    item.addEventListener('mouseout', function () {
      this.style.backgroundColor = 'transparent';
    });
  });

  function openCV() {
    const cvUrl = 'https://github.com/andresalmeida/Desarrollo_Web_Avanzado_14956/blob/main/CV/multimedia/CV%20Andres%20Almeida.pdf';
    window.open(cvUrl, '_blank');
  }
  
  
  



  // PARA LA SECCION HABILIDADES 

  document.querySelectorAll('.skill-item').forEach(item => {
    item.querySelector('.skill-preview').addEventListener('click', function() {
      const details = this.nextElementSibling;
      const skillItem = this.parentNode;
  
      skillItem.classList.toggle('open');
  
      if (skillItem.classList.contains('open')) {
        details.style.display = 'block';
      } else {
        details.style.display = 'none';
      }
    });
  });

  
  // PARA LA SECCION PROYECTOS

  document.querySelectorAll('.project-preview').forEach(preview => {
    preview.addEventListener('click', function() {
      const details = this.nextElementSibling;
      const projectItem = this.parentNode;
  
      projectItem.classList.toggle('open');
  
      if (projectItem.classList.contains('open')) {
        details.style.display = 'block';
      } else {
        details.style.display = 'none';
      }
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


  
  
  
  