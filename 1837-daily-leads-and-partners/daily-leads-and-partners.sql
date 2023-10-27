/* Write your T-SQL query statement below */
select date_id, make_name, Count(Distinct lead_id) as unique_leads, Count(Distinct partner_id) as unique_partners
from DailySales
group by date_id, make_name