var data = [
  { Id: 1, Author: "Rian2", Text: "Pretty well", Data: Date() },
  { Id: 2, Author: "Toby2", Text: "Pretty fine", Data: Date() },
  { Id: 3, Author: "Ruan2", Text: "Thats Ok", Data: Date() }
];

var CommentBox = React.createClass({
  render: function() {
    return (
      <div className="commentBox">
        <h1>Comments</h1>
        <CommentList data={this.props.data} />
        <CommentForm />
      </div>
    );
  }
});

var CommentList = React.createClass({
  render: function() {
    var commentNodes = this.props.data.map(function(comment) {
      return (
        <Comment author={comment.Author} key={comment.Id}>{comment.Text}
        </Comment>
      );
    });
    return (
      <div className="commentList">{commentNodes}
      </div>
    );
  }
});

var CommentForm = React.createClass({
    render: function() {
        return (
          <div className="commentForm">
              Hello, world! I am a CommentForm.
          </div>
      );
    }
});

var Comment = React.createClass({
  rawMarkup: function() {
    var md = new Remarkable();
    var rawMarkup = md.render(this.props.children.toString());
    return { __html: rawMarkup };
  },

  render: function() {
    return (
      <div className="comment">
        <h2 className="commentAuthor">{this.props.author}
        </h2>
        <span dangerouslySetInnerHTML={this.rawMarkup()} />
      </div>
    );
  }
});

ReactDOM.render(
  <CommentBox data={data} />,
  document.getElementById('content')
);