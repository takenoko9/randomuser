$.ajax({
  url: 'https://randomuser.me/api/',
  dataType: 'json',
  success: function(data) {
      $("img").attr("src", data.results[0].user.picture.medium);
  }
});
