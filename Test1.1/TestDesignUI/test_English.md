I. First, we need to analyze the general layout and break it down into specific components.
    We will divide the page into the following main components:
    1. Navigation bar
    2. Setting menu bar (including Welcome Peldi, History, Preferences, Administration, Log out)
    3. Left menu bar
    4. Content
        4.1 Main text
        4.2 Content options
        4.3 Comments

II. Approach description
1. For desktop and laptop screens, we will present the components as in the mockup.

2. For mobile screens (just support vertically only, if used horizontally, it will also display the same interface vertically), as the width tends to be narrower and expands vertically, we need to redesign the position, size, and style of the components as follows:
Update as follows:

- The navigation bar will remain at the top of the screen but will be collapsed:
- Breadcrumbs: Display only the two most recent router positions and hide their parent positions.
    Example: Dashboard > Main > Home => ... > Main > Home
- Search: Combine the input field and the button into one element and collapse it. When users click on it, it will expand the input field horizontally and show the search submit button.
- The options of the setting menu bar will be combined into an option button and placed in the top right corner of the screen (within the mobile navigation bar). Clicking on it will display the options.
- The left menu bar will be combined into a menu option button and placed on the left side of the screen (within the mobile navigation bar). Clicking on it will display the menu options.
- The content section will expand to occupy the entire width of the screen and appear below the components mentioned above. Child components will be positioned from top to bottom and take up the entire width of the parent component

3. Tablet: Depends on size and ratio. If the size is large, it will display like a desktop, if it is small, it will look like a mobile

III. Coding
1. DOM structure design example:
<html>
    <body>
        <div class="navigation-bar"></div>
        <div class="setting-menu-bar"></div>
        <div class="left-menu-bar"></div>
        <div class="content">
            <div class="main-text"></div>
            <div class="content-option"></div>
            <div class="comments"></div>
        </div>
    </body>
</html>

2. CSS design:
- Preferably use flexbox for optimizing responsiveness.
- Set the navigation bar to stick to the top of the screen.
- Set the setting menu bar to stick to the top of the screen below the navigation bar (position will depend on the height of the navigation bar).
- The left menu bar will stick to the left side of the screen below the navigation bar.
- Finally, the content section will be at the bottom right of the screen.
- Use media queries to apply different styles for screens of various sizes, for example:
Adjust the CSS styles and layout as needed to ensure your website is responsive and looks great on different devices and screen sizes.

``

    // Styles for mobile screens
    @media (max-width: 768px) {
        // Mobile styles
    }

    // Styles for tablet screens
    @media (min-width: 769px) and (max-width: 1024px) {
        // Tablet styles
    }

    // Styles for common desktop screens
    @media (min-width: 1025px) {
        // Desktop styles
    }
    
``
