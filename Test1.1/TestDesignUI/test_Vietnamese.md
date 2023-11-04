I. Đầu tiên ta cần phân tích layout chung và chia ra các component cụ thể. 
Ta sẽ chia page ra thành các component chính:
1. Navigation bar
2. Setting menu bar (include Welcome Peldi, History, Preferences, Adminstration, Log out)
3. Left menu bar
4. Content
    Main text
    Content option
    Comments

II.
 1. Với màn hình desktop, laptop thì sẽ trình bày các component nhưng trong mockup.

 2. Với màn hình mobile (nếu sử dụng theo chiều ngang thì cũng hiển thị giao diện giống chiều dọc) thì có xu hướng hẹp bề ngang và mở rộng theo chiều dọc, nên cần phải  thiết kế lại vị trí xuất hiện, kích thước, style của các component
Update như sau:
- Navigation bar vẫn nằm trên cùng của màn hình nhưng sẽ được thu gọn lại:
    Phần breadcrumbs: Chỉ cần hiển thị 2 vị trí router mới nhất và ẩn các vị trí cha của chúng
    Vd: Dashboard > Main > Home  => ... > Main > Home
    Phần Search: Gom input field và button thành 1 element và thu gọn lại, khi người dùng click vào thì sẽ mở rộng theo chiều ngang input field và hiển thị nút submit search.

- Các options của setting menu bar sẽ gom thành nút option và đặt nó bên trên góc phải của màn hình (nằm trong thành navigation bar của mobile, click vào sẽ được list ra)

- Left menu bar sẽ được gom thành nút menu option và đặt nó bên trái của màn hình (nằm trong thành navigation bar của mobile, click vào sẽ được list ra)

- Phần content sẽ mở rộng chiếm hết chiều ngang của màn hình và bên dưới cái component nói trên. Các component con sẽ được set vị trí từ trên xuống dưới và chiếm hết chiều ngang của component cha

 3. Tablet: Tuỳ vào kích thước và tỉ lệ. Nếu có kích thước to thì sẽ cho hiển thị giống với desktop còn nhỏ thì giống mobile

Phần thiết kế DOM structure:
    Ex:
    <html>
        <body>
            <class="navigation-bar">
            <class="setting-menu-bar">
            <class="left-menu-bar">
            <class="content">
                <class="main-text">
                <class="content-option">
                <class="comments">
            </>
        </>
    </>

Phần thiết kế CSS:
    Ưu tiên sử dụng flex box để tối ưu hoá cho responsive
    Navigation bar set vị trí bám vào bên top của màn hình
    Setting menu bar set vị trí bám vào top màn hình bên dưới Navigation bar (vị trí sẽ phụ thuộc vào chiều cao của Navigation bar)
    Left menu bar sẽ bám vào left màn hình và bên dưới Navigation bar
    Cuối cùng là phần content sẽ nằm bên right bottom của màn hình.
Sử dụng các thuộc tính để set sự thay đổi screen size cho các thiết bị nhỏ hơn.

    Ex: 
    // Styles for mobile screen
        @media (max-width: 768px) // Styles for mobile screen
    // Styles for table screen
        @media (min-width: 769px) and (max-width: 1024px)
    // Styles for common desktop
        @media (min-width: 1025px)

