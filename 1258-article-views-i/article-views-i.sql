/* Write your T-SQL query statement below */
select author_id as id
from Views
where (author_id = viewer_id)
group by author_id
order by id ASC